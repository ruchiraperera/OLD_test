*** nullable variables value type can be have null

int number = null //gives an error
NUllable<int> number = null; //this will be ok
int? number = null; //short form of nullable variable define


*** best practise for readonly variable ( according to the example, List of order can be initialize two times. 
Therefore with readonly in restricted to initialise in constructor or etc. )

public class Customer{
	
	public List<Order> order

	public Customer(){
		
		this.order = new List<Order>();
	
	}


	public OrderProcess(){
		
		this.order = new List<Order>();

	}
}


*** tryparse or parse

same function but parse throw exception and tryparse comes with try catch. becuase of that, there is no exception throw.



*** contructor overloading possible but not  (when default constructor is not going to be 
there when user define any constructor in coding).

public class Customer{

	//default constructor
	public Customer(){
	
	}

	//constructor overloading with calling defualt constructor as well.
	public Customer(string name):this(){
	
	}
}

*** params 

public class Customer{
	
	public void marks(params int[] array){
	
	}

}

we can call like - 


var _customer = new Customer();
_customer.marks(1,2,3);