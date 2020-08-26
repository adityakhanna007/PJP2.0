package com.sapient.week2.java_date_time_calc;

import java.util.Calendar;
import java.util.Date;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.servlet.ModelAndView;

@RestController
public class datetimeController {
	@Autowired
	datetimedao datetimedao;
	@GetMapping("/home")
	public ModelAndView viewAll(Model model)
	{
		return new ModelAndView("home");
	}
	@GetMapping("/choice")
	public ModelAndView show(@RequestParam("choice") int choice, Model model)
	{
		if(choice==1)
		return new ModelAndView("page1");
		else if(choice==2)
			return new ModelAndView("page2");
		else if(choice==3) 
			return new ModelAndView("page3");
		else if(choice==4)
			return new ModelAndView("page4");
		else
			return new ModelAndView("page5");
	}
	@GetMapping("/page1")
	public ModelAndView f1(@RequestParam("date1") int date1,
			@RequestParam("month1") int month1,
			@RequestParam("year1") int year1,
			@RequestParam("hr1") int hour1,
			@RequestParam("min1") int min1,
			@RequestParam("sec1") int sec1,
			@RequestParam("date2") int date2,
		@RequestParam("month2") int month2,
			@RequestParam("year2") int year2,
			@RequestParam("hr2") int hour2,
			@RequestParam("min2") int min2,
			@RequestParam("sec2") int sec2,
			@RequestParam("operation") int op,
			Model model)
	{
		month1--;month2--;
		Calendar cal1= Calendar.getInstance();
		cal1.set(year1,month1,date1,hour1,min1,sec1);
		Calendar cal2= Calendar.getInstance();
		cal2.set(year2,month2,date2,hour2,min2,sec2);
        if(op==1) {
        	model.addAttribute("ans",datetimedao.add2dates(cal1, cal2));
    		return new ModelAndView("page1");
        }
        else
        {
        	model.addAttribute("ans",datetimedao.sub2dates(cal1, cal2));
        	return new ModelAndView("page1");
        }
		
		
	}
	@GetMapping("/page2")
	public ModelAndView f2(@RequestParam("date") int date,
			@RequestParam("month") int month,
			@RequestParam("year") int year,
			@RequestParam("hr") int hour,
			@RequestParam("min") int min,
			@RequestParam("sec") int sec,
			@RequestParam("input") int input,
			@RequestParam("option") int choice, 
			@RequestParam("operation") int op,
			Model model)
	{ month--;
		if(choice==2)
			input=7*input;
		if(choice==3)
			input=30*input;
		Calendar cal= Calendar.getInstance();
		cal.set(year,month,date,hour,min,sec);
		//Calendar cal2= Calendar.getInstance();
		//cal2.set(year2,month2,date2,hour2,min2,sec2);
       
        if(op==2)
        	input=-1*input;
		model.addAttribute("ans",datetimedao.adddays(cal, input));
		return new ModelAndView("page2");
		
		
	}
	@GetMapping("/page3")
	public ModelAndView f3(@RequestParam("date") int date,
			@RequestParam("month") int month,
			@RequestParam("year") int year,
			@RequestParam("hr") int hour,
			@RequestParam("min") int min,
			@RequestParam("sec") int sec,
			//@RequestParam("input") int input,
			Model model)
	{ month--;
		Calendar cal= Calendar.getInstance();
		cal.set(year,month,date,hour,min,sec);
		//Calendar cal2= Calendar.getInstance();
		//cal2.set(year2,month2,date2,hour2,min2,sec2);
       
        
       
		model.addAttribute("ans",datetimedao.dayofweek(cal));
		return new ModelAndView("page3");
		
		
	}
	@GetMapping("/page4")
	public ModelAndView f4(@RequestParam("date") int date,
			@RequestParam("month") int month,
			@RequestParam("year") int year,
			@RequestParam("hr") int hour,
			@RequestParam("min") int min,
			@RequestParam("sec") int sec,
			//@RequestParam("input") int input,
			Model model)
	{ month--;
		Calendar cal= Calendar.getInstance();
		cal.set(year,month,date,hour,min,sec);
		//Calendar cal2= Calendar.getInstance();
		//cal2.set(year2,month2,date2,hour2,min2,sec2);
       
        
       
		model.addAttribute("ans",datetimedao.weeknum(cal));
		return new ModelAndView("page4");
		
		
	}
	@GetMapping("/page5")
	public ModelAndView f4(@RequestParam("option") int option,
			
			Model model)
	{ 
		
		//Calendar cal2= Calendar.getInstance();
		//cal2.set(year2,month2,date2,hour2,min2,sec2);
       
		model.addAttribute("ans",datetimedao.translate(option));
		return new ModelAndView("page5");
		
		
	}
	
	

}
