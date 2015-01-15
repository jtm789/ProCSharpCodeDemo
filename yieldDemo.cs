public class GameMove{
	private IEnumerator cross;
	private IEnumerator circle;
	
	public GameMoves(){
		cross=Cross();
		circle=Circle();
	}
	
	private int move =0;
	const int MaxMoves=9;
	
	public IEnumerator Cross(){
		while(true){
			Console.WriteLine("Cross,move {0}",move);
			if(++move>=MaxMoves)
				yield break;
			yield return circle;
		}
	}
	public IEnumerator Circle(){
		while(true){
			while(true){
				Console.WriteLine("Circle ,move {0}",move);
				if(++move>=MaxMoves)
					yield break;
				yield return cross;
			}
		}
	}
}
//client
var game = new GameMoves();
IEnumerator enumerator = game.Cross();
while(enumerator.MoveNext()){
	enumerator = enumerator.Current as IEnumerator;
}

//output:
Cross,move 0
Circle,move 1
Cross,move 2
Cirle,move 3
Cross,move 4
Circle,move 5 
Cross ,move 6
Circle,move 7
Cross,move 8



