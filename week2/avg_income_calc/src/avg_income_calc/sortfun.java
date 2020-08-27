package avg_income_calc;

import java.util.Comparator;

public class sortfun implements Comparator<incomepojo>{

	@Override
	public int compare(incomepojo p1, incomepojo p2) {
		// TODO Auto-generated method stub
	    if(p1.getCountry().contentEquals(p2.getCountry())) {
	    	 return p1.getGender().compareTo(p2.getGender());
	    	 
	    }
	    else
	    	return p1.getCountry().compareTo(p2.getCountry());
	}

	

}
