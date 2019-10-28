<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
//	var a= new A();
	"tototot".GetHashCode().Dump();
	"totototw".GetHashCode().Dump();
	
}

public class A {
	private Dictionary<int,int> _myDictionary= new Dictionary<int,int>();
	private List<int> _myList= new List<int>();
	
	public A(){
	TestDictionary();
	TestList();
	}
	
	private void TestDictionary(){
		var stopwatch = new Stopwatch();
	
		_myDictionary.Add(new KeyValuePair<int,int>(5,6));
	
        // Begin timing.
        stopwatch.Start();
		
		for(int i=0;i<10000000; i++){
		
		var randomNumber = new Random().Next(0,3000);
		
			if(!_myDictionary.TryGetValue(randomNumber, out var value)){
			_myDictionary.Add(randomNumber,randomNumber);
			}
		}
		
		stopwatch.Stop();
		
		stopwatch.Elapsed.Dump();
	}
	
	private void TestList(){
		var stopwatch = new Stopwatch();

        // Begin timing.
        stopwatch.Start();
		
		for(int i=0;i<10000000; i++){
		
		var randomNumber = new Random().Next(0,3000);
		
			if(!_myList.Contains(randomNumber)){
				_myList.Add(randomNumber);
			}
		}
		
		stopwatch.Stop();
		
		stopwatch.Elapsed.Dump();
	}
}