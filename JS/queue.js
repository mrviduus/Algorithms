class Node{
  constuctor(value){
    this.value = value;
    this.next = null;
  }
}

class Queue {
  constuctor(){
    this.first = null;
    this.last = null;
    this.size = 0;
  }
  enqueue(val){
    var newNode = new Node(val);
    if(!this.first){
      this.first = newNode;
      this.last = newNode;
    }
    else{
      this.last.next = newNode;
      this.last = newNode;
    }
    return ++this.size;

  }
  dequeue(){
    if(!this.first) return null;

    var temp = this.first;
    if(this.first === this.last){
      this.last = null;
    }
    this.first = this.first.next;
    this.size--;
    return temp.value;

  }
}

var q = new Queue();
q.enqueue("first");
q.enqueue("second");
console.log(q);
q.dequeue();
console.log(q);
