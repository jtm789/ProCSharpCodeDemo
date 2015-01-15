static int sumofSegments(ArraySegment<int>[] segments){
	int sum=0;
	foreach(var segment in segments){
		for( int i = segment.Offset; i<segment.Offset+segment.count;i++){
			sum +=segment.Array[i];
		}	
	}
	return sum;
}

///数组段
int [] ar1={1,4,5,11,13,18};
int [] ar2={3,4,5,18,21,27,33};
var segments=new ArraySegment<int>[2]{
	new ArraySegment<int>(ar1,0,3),//第一个数组，从下标0开始，取3个，即ar1[0],ar1[1],ar1[2]
	new ArraySegment<int>(ar2,3,3)//从下标3开始，取3个 ar2[3],ar2[4],ar2[5]
};

var sum=SumOfSegments(segments);

//数组段是结构struct，不复制数组，只是访问数组，对于ArraySegment的修改会反应到数组上。