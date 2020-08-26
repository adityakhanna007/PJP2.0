package com.sapient.week2.java_date_time_calc;

import org.springframework.stereotype.Component;

@Component
public class datetimePojo {
  private int date;
  private int month;
  private int year;
public int getDate() {
	return date;
}
public void setDate(int date) {
	this.date = date;
}
public int getMonth() {
	return month;
}
public void setMonth(int month) {
	this.month = month;
}
public int getYear() {
	return year;
}
public void setYear(int year) {
	this.year = year;
}
  
}
