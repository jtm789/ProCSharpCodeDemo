foreach语句

foreach(var p in persons)
{
	Console.WriteLine(p);
}
C#将其解析为
IEnumeratoer<Person> enumerator = persons.GetEnumerator();
while(enumerator.MoveNext()){
	Person p=enumerator.Current;
	Console.WriteLine(p);
}


yield语句

using System;
using System.Collections;

namespace Wrox.ProCSharp.Arrays{
	public class HelloCollection{
		public IEnumerator<string>
		{
			yield return "Hello";
			yield return "World";
		}
	
	}
}

//包含yield语句的方法或者属性，称为迭代块。必须返回IEnumerator或者IEnumerable接口。可以有多个yield return,或者yield break,但不能包含return 语句。

public void HelloWorld()
{
	var helloCollection =new HellCollection();
	foreach( var s in helloCollection)
	{
		Console.WriteLine(s);
	}
}

//yield
public class MusicTitles{
	string [] names={"Tubular Bells","Hergest Ridge","Ommadawn","Platinum"};
	
	public IEnumerator<string> GetEnumerator()
	{
		for(int i=0;i<4;i++){
			yield return names[i];
		}
	}
	
	public IEnumerable<string> Reverse(){
		for(int i=3;i>=0;i--){
			yield return names[i];
		}
	}
	
	public IEnumerabler<string> Subset(int index,int length)
	{
		for(int i= index;i<index+length;i++){
			yield return names[i];
		}
	}
}

//使用MusicTitle
var titles = new MusicTitles();
foreach( var title in titles){
	Console.WriteLine(title);
}
Console.WriteLine();
Console.WriteLine("reverse");
foreach(var title in titles.Reverse()){
	Console.WriteLine(title);
}
Console.WriteLine();

Console.WriteLine("subset");
foreach(var title in title.Subset(2,2)){
	Console.WriteLine(title);
}
