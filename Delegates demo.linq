<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
//	var aClass= new A();
	
//	var bClass= new B();
	
	var cClass= new C();
}

public class A {

private delegate double Divider(int a, int b);

	public A(){
		var dividerOne = new Divider((x,b)=>{return 5;});
		var dividerTwo = new Divider(GetDivider);
		Divider dividerThree = (a,b) => {return 6;};
		Divider dividerThreeB = (a,b) => 6;
		
		var dividerOneResult = dividerOne(5,6);
		var dividerTwoResult =dividerTwo(100,2);
		var dividerThreeResult =dividerThree(20,25);
		var dividerThreeBResult =dividerThreeB(30,38);
		
		dividerOneResult.Dump();
		dividerTwoResult.Dump();
		dividerThreeResult.Dump();
		dividerThreeBResult.Dump();
	}
	
	private double GetDivider(int a, int b){
	return a/b;
	}
}

public class B { 
	private Func<int,int,int> Multiplier;
	
	public B(){
	Multiplier = (a,b)=>{
	return a*b;
	};
	
	var m1Result = Multiplier(5,6);
	
	m1Result.Dump();
	
	Multiplier= MultiplierMethod;
	
	var m2Result =Multiplier(12,15);
	
	
	m2Result.Dump();
	}
	
	private int MultiplierMethod(int a, int b){
	return a*b;
	}
}

public class C{

		private Action<int,int> Multiplier;
	
	public C(){
	Multiplier = (a,b)=>{
	(a*b).Dump();
	};
	
	Multiplier(5,6);
	
	
	Multiplier= MultiplierMethod;
	Multiplier(12,15);
	}
	
	private void MultiplierMethod(int a, int b){
	(a*b).Dump();
	}

}