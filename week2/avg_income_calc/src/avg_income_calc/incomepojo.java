package avg_income_calc;

public class incomepojo {
 private String city;
 private String country;
 private String gender;
 private String currency;
 private double avg_income;
public String getCity() {
	return city;
}
public void setCity(String city) {
	this.city = city;
}
public String getCountry() {
	return country;
}
public void setCountry(String country) {
	this.country = country;
}
public String getGender() {
	return gender;
}
public void setGender(String gender) {
	this.gender = gender;
}
public String getCurrency() {
	return currency;
}
public void setCurrency(String currency) {
	this.currency = currency;
}
public double getAvg_income() {
	return avg_income;
}
public void setAvg_income(double avg_income) {
	this.avg_income = avg_income;
}
@Override
public String toString() {
	return "incomepojo [city=" + city + ", country=" + country + ", gender=" + gender + ", currency=" + currency
			+ ", avg_income=" + avg_income + "]";
}
public incomepojo(String city, String country, String gender, String currency, double avg_income) {
	super();
	this.city = city;
	this.country = country;
	this.gender = gender;
	this.currency = currency;
	this.avg_income = avg_income;
}
 
}
