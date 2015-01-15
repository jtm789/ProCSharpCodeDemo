	Array intArray1=Array.CreateInstance(typeof(int),5);
	for( int i=0;i<5;i++){
		intArray1.SetValue(33,i);
	}
	for( int i=0;i<5;i++){
		Console.WriteLine(intArray1.GetValue(i));
	}

//排序1
string [] names = {
		"Christina Aguilera",
		"Shakira",
		"Beyonce",
		"Gwen Stenfani"
		};

		Array.Sort(names);
		foreach( var name in names){
			Console.WriteLine(name);
		}
		//output:
		Beyonce
		Christina Aguilera
		Gwen Stenfani
		Shakira
//排序2
public class Person:IComparable<Person>{
	
	public int CompareTo(Person other){
		if(other==null) throw new ArgumentNllException("other");
		int result = this.LastName.CompareTo(other.LastName);
		if(result==0){
			result=this.FirstName.CompareTo(other.FirstName);
			return result;
		}
	}

}

Person[] persons={
	new Person{FirstName="Damon",LastName="Hill"},
	new Person{FirstName="Niki",LastName="Lauda"},
	new Person{FirstName="Ayrton",LastName="Senna"},
	new Person{FirstName="Graham,LastName="Hill"}
	};
Array.Sort(persons);
foreach(var p in persons)
{
	Console.WriteLine(p);
}

//output:
Damon Hill
Garham Hill
Niki Lauda 
Ayrton Senna
//排序3
public enum PersonCompareType{
FirstName,
LastName
}

public class PersonComparer:ICompare<Person>
{
	private PersonCompareType compareType;
	
	public PersonComparer(PersonCompareType compareType){
		this.compareType=compareType;
	}
	
	public int Compare(int x,int y){
		if(x==null) throw new ArgumentNullException("x");
		if(y==null) throw new ArgumentNullException("y");
		switch(compareType){
			case PersonCompareType.FirstName:
				return x.FirstName.CompareTo(y.FirstName);
		   case PersonCompareType.LastName:
				return x.LastName.CompareTo(y.LastName);
			default:
				throw new ArgumentException("unexpected compare type");
		}
	}
}
	/*new Person{FirstName="Damon",LastName="Hill"},
	new Person{FirstName="Niki",LastName="Lauda"},
	new Person{FirstName="Ayrton",LastName="Senna"},
	new Person{FirstName="Graham,LastName="Hill"}*/
Array.Sort(persons,new PersonComparer(PersonCompareType.FirstName));
foreach(var p in persons){
	Console.WriteLine(p);
}
//output:
Ayrton Senna
Damon Hill
Graham Hill
Niki Lauda 

