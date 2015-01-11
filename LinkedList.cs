public class LinkedLidt<T>:IEnumerable<T>
{
	public LinkedListNode<T> First{get;private set;}
	public LinkedListNode<T> Last{get;private set;}

	public LinkedListNode<T> AddLast(T node){
		var newNode = new LinkedListNode(node);
		if(First==null){
			First=newNode;
			newNode.Prev=Last;
			Last=First;
		}
		else{
			LinkedListNode previous =Last;
			last.Next=newNode;
			Last=newNode;
			Last.Prev=previous;
		}
		return newNode;
	}

	public IEnumerator<T> GetEnumerator(){
		LinkedListNode<T> current=First;

		while(current!=null){
			yield return current.Value;
			current=current.Next;
		}
	}

	IEnumerator IEnumerable.GetEnumerator(){
		return GetEnumerator();
	}

}