//元祖，用于不同类型对象放在同一个数组
public static Tuple<int,int>Divide(int dividend,int divisor){
	int result=dividend/divisor;
	int reminder = dividend % divisor;
	
	return Tuple.Create<int,int>(result,reminder);
}

//调用
var result=Divide(5,2);
Console.WriteLine("result of division: {0},reminder: {1}",result.Item1,result.Item2);

//多个的情况
public class Tuple<T1,T2,T3,T4,T5,T6,T7,TRest>
超过8个
var tuple= Tuple.Create<string,string,string,int,int,int,double,Tuple<int,int>>(
"aaa","bbb","US",2000,1,2,1.37,Tuple<int,int>(52,3490)
);
