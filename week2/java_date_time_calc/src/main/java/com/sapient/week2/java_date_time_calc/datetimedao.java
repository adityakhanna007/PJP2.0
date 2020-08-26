package com.sapient.week2.java_date_time_calc;

import java.io.FileWriter;
import java.io.IOException;
import java.util.Calendar;
import java.util.Date;

import org.springframework.stereotype.Component;
import org.springframework.stereotype.Service;

@Service
public class datetimedao {

	public Date add2dates(Calendar cal1,Calendar cal2) {
		Calendar caltotal=(Calendar)cal1.clone();
		caltotal.add(Calendar.YEAR, cal2.get(Calendar.YEAR));
		caltotal.add(Calendar.MONTH, cal2.get(Calendar.MONTH));
		caltotal.add(Calendar.DATE, cal2.get(Calendar.DATE));
		caltotal.add(Calendar.HOUR_OF_DAY, cal2.get(Calendar.HOUR_OF_DAY));
		caltotal.add(Calendar.MINUTE, cal2.get(Calendar.MINUTE));
		caltotal.add(Calendar.SECOND, cal2.get(Calendar.SECOND));
		Date ans=caltotal.getTime();
		try
		{
		    String filename= "history.txt";
		    FileWriter fw = new FileWriter(filename,true);
		    fw.write("\n"+"Input Option 1 : Date1 : "+ cal1.getTime() + " Date2 : "+cal2.getTime()+ "\n");
		    fw.write("Output :"+ "\n");
		    fw.write("New date after adding Two dates : "+ ans+ "\n");
		    fw.write("================================================================================================"+ "\n");
		    fw.close();
		}
		catch(IOException msg)
		{
		    System.err.println("IOException: " + msg.getMessage());
		}
		return ans;
	}
	public String sub2dates(Calendar cal1,Calendar cal2)
	{
		long miliSecondForDate1 = cal1.getTimeInMillis();
		long miliSecondForDate2 = cal2.getTimeInMillis();

		// Calculate the difference in millisecond between two dates
		long diffInMilis = miliSecondForDate1 - miliSecondForDate2;

		/*
		 * Now we have difference between two date in form of millsecond we can
		 * easily convert it Minute / Hour / Days by dividing the difference
		 * with appropriate value. 1 Second : 1000 milisecond 1 Hour : 60 * 1000
		 * millisecond 1 Day : 24 * 60 * 1000 milisecond
		 */

		long diffInSecond = diffInMilis / 1000;
		long diffInMinute = diffInMilis / (60 * 1000);
		long diffInHour = diffInMilis / (60 * 60 * 1000);
		long diffInDays = diffInMilis / (24 * 60 * 60 * 1000);
		long diffInWeeks=diffInMilis /(24*60*60*1000*7);
		long diffInMonths=diffInDays /(30);
		try
		{
		    String filename= "history.txt";
		    FileWriter fw = new FileWriter(filename,true);
		    fw.write("\n"+"Input Option 1 : Date1 : "+ cal1.getTime() + " Date2 : "+cal2.getTime()+ "\n");
		    fw.write("Output :"+ "\n");
		    fw.write("Difference between 2 dates: "+"diffinDays: "+diffInDays+" DiffInWeeks: "+diffInWeeks+" DiffInMonths: "+diffInMonths+ "\n");
		    fw.write("================================================================================================"+ "\n");
		    fw.close();
		}
		catch(IOException msg)
		{
		    System.err.println("IOException: " + msg.getMessage());
		}
		return "diffinDays: "+diffInDays+" DiffInWeeks: "+diffInWeeks+" DiffInMonths: "+diffInMonths;
	}
	public Date adddays(Calendar cal,int days)
	{   Date curr=cal.getTime();
		cal.add(Calendar.DATE, days);
		Date ans=cal.getTime();
		try
		{
		    String filename= "history.txt";
		    FileWriter fw = new FileWriter(filename,true);
		    fw.write("\n"+"Input Option 2 : Date : "+ curr + "\n");
		    fw.write("Output :"+ "\n");
		    if(days>=0)
		    fw.write("New date after adding "+ days +" days : "+ ans+ "\n");
		    else
		    fw.write("New date after subtracting "+ -1*days +" days : "+ ans+ "\n");
		    fw.write("================================================================================================"+ "\n");
		    fw.close();
		}
		catch(IOException msg)
		{
		    System.err.println("IOException: " + msg.getMessage());
		}
		return ans;
	}
	public String  dayofweek(Calendar cal)
	{   
		int day= cal.get(Calendar.DAY_OF_WEEK);
		try
		{
		    String filename= "history.txt";
		    FileWriter fw = new FileWriter(filename,true);
		    fw.write("\n"+"Input Option 3 : Date : "+ cal.getTime() + "\n");
		    fw.write("Output :"+ "\n");
		    fw.write("Day of Week : "+ day+ "\n");
		    fw.write("================================================================================================"+ "\n");
		    fw.close();
		}
		catch(IOException msg)
		{
		    System.err.println("IOException: " + msg.getMessage());
		}
		if(day==1)
			return "Sunday";
		else if(day==2)
			return "Monday";
		else if(day==3)
			return "Tuesday";
		else if(day==4)
			return "Wednesday";
		else if(day==5)
			return "Thursday";
		else if(day==6)
			return "Friday";
		else return "Saturday";
		
	}
	
	public int weeknum(Calendar cal) {
		
		try
		{
		    String filename= "history.txt";
		    FileWriter fw = new FileWriter(filename,true);
		    fw.write("\n"+"Input Option 4 : Date : "+ cal.getTime() + " \n");
		    fw.write("Output :"+ "\n");
		    fw.write("Week number for the given date : "+cal.get(Calendar.WEEK_OF_YEAR)+ "\n");
		    fw.write("================================================================================================"+ "\n");
		    fw.close();
		}
		catch(IOException msg)
		{
		    System.err.println("IOException: " + msg.getMessage());
		}
		return cal.get(Calendar.WEEK_OF_YEAR);
	}
	
	public Date translate(int option)
	{
		Calendar cal=Calendar.getInstance();
		Date prev=cal.getTime();
		switch(option)
		{
		
		case 2:{cal.add(Calendar.DATE,1);break;}
		case 3:{cal.add(Calendar.DATE,2);break;}
		case 4:{cal.add(Calendar.DATE,-1);break;}
		case 5:{cal.add(Calendar.DATE,-2);break;}
		case 6:{cal.add(Calendar.DATE,-7);break;}
		case 7:{cal.add(Calendar.DATE,+7);break;}
		case 8:{cal.add(Calendar.MONTH,1);break;}
		case 9:{cal.add(Calendar.YEAR,1);break;}
		
		}
		
		Date ans=cal.getTime();
		try
		{
		    String filename= "history.txt";
		    FileWriter fw = new FileWriter(filename,true);
		    fw.write("\n"+"Input Option 5 : Date : "+ prev + "\n");
		    fw.write("Output :"+ "\n");
		    fw.write("The output of the option "+ option+"is :"  +ans+ "\n");
		    fw.write("================================================================================================"+ "\n");
		    fw.close();
		}
		catch(IOException msg)
		{
		    System.err.println("IOException: " + msg.getMessage());
		}
		return ans;
		
		}
	
}

