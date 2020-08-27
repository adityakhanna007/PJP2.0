package avg_income_calc;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;



public class income_calc_runner {
	public static void main(String[] args)
	{
		//reading the csv file and conversion of currency to US dollar 
  String delimiter=",";
 incomedao dao=new incomedao();
  try {
	  File file=new File("Sample input file Assignment 3.csv");
      FileReader fr=new FileReader(file);
		 BufferedReader br=new BufferedReader(fr); 
		 String line="";
		 String [] temp;
		 int cnt=1;
		 while((line=br.readLine())!=null) {
			 if(cnt==1)
			 {
				 cnt++;continue;
			 }
			 temp=line.split(delimiter);
			 
			 String curr=temp[3];
			 if(temp[1].equals(""))
			 {
				temp[1]=temp[0];
			 }
			 //System.out.println(temp[0]+temp[1]+temp[2]+temp[3]+temp[4]);
			 double avg_income=Double.parseDouble(temp[4]);
			 if(curr.equals("INR"))
				 avg_income/=66;
			 
			 else if(curr.equals("SGP"))
				 avg_income/=1.5;
		  else if(curr.equals("HKD"))
		     avg_income/=8;
		     else if(curr.equals("GBP"))
		    	 avg_income/=0.67;
	dao.getList().add(new incomepojo(temp[0],temp[1],temp[2],temp[3],avg_income));
		 
		 }
  }catch(Exception e)
  {
	 e.printStackTrace();
  }
   
  
  
  //Grouping of record on basis of country and gender
  
  Collections.sort(dao.getList(),new sortfun());
  List<incomepojo> report=new ArrayList<>();
  if(dao.getList().size()==0)
  	System.out.println("list is empty");
  else
  {
  	report.add(dao.getList().get(0));
  	for(int i=1;i<dao.getList().size();i++)
  	{   int ind=report.size()-1;
  		if(dao.getList().get(i).getCountry().equals(report.get(ind).getCountry())&&
  		   dao.getList().get(i).getGender().equals(report.get(ind).getGender()))
  		{
  			Double data=report.get(ind).getAvg_income();
  		    data+=dao.getList().get(i).getAvg_income();
  		    report.get(ind).setAvg_income(data);
  		}
  		else
  			report.add(dao.getList().get(i));
  	}
  	BufferedWriter bw=null;
	 try {
		 File file=new File("summary_report.csv");
		 if(!file.exists())
			 file.createNewFile();
	 FileWriter fw=new FileWriter(file);
	 bw=new BufferedWriter(fw);
	 bw.write("City/Country,Gender,Average Income(in USD)");
	 bw.newLine();
	 for(incomepojo record:report)
	 {   
	     
		 bw.write(String.join(",",record.getCountry(),record.getGender(),Double.toString(record.getAvg_income())));
		 bw.newLine();
		 
	 }
	 bw.close();
	 }
	 catch(Exception e)
	 {
		 e.printStackTrace();
	 }
  	
  	
  	
		 }
   System.out.println("success");
}
}
