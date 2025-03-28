class Node{
  constructor(val){
    this.val = val;
    this.next = null;
  }
}

class SinglyLinkedList{
  constructor(){
    this.head = null;
    this.tail = null;
    this.lenght = null;
  }
  push(val){
    var newNode = new Node(val);
    if(!this.head){
      this.head = newNode;
      this.tail = this.head;
    }else {
      this.tail.next = newNode;
      this.tail = newNode;
    }
    this.lenght ++;
    return this;
  }
  pop(){
    if(!this.head) return undefined;
    var current = this.head;
    var newTail = current;
    while(current.next){
      newTail = current;
      current = current.next;
    }
    this.tail = newTail;
    this.tail.next = null;
    this.lenght--;
    if(this.lenght === 0){
      this.head = null;
      this.tail = null;
    }
    return current;
  }
  shift(){
    if(!this.head) return undefined;
    var currentHead = this.head;
    this.head = currentHead.next;
    this.lenght--;
    if(this.lenght === 0){
      this.tail = null;
    }
    return currentHead;
  }
  unshift(val){
    var newNode = new Node(val);
    if(!this.head){
      this.head = newNode;
      this.tail = this.head;
    }else{
      newNode.next = this.head;
      this.head = this.head;
    }
    newNode.next = this.head;
    this.head = newNode;
    this.lenght ++;
    return this;
  }
  get(index){
    if(index < 0 || index >= this.lenght) return null;
    var counter = 0;
    var current = this.head;
    while(counter !== index){
      current = current.next;
      counter ++;
    }
    return current;
  }
  set(index, val){
    var foundNode = this.get(index);
    if(foundNode){
      foundNode.val = val;
      return true;
    }
    return false;
  }
  insert(index, val){
    if(index < 0 || index > this.lenght) return false;
    if(index === this.lenght) return !!this.push(val);
    if(index === 0) return !!this.unshift(val);
    var newNode = new Node(val);
    var prev = this.get(index - 1);
    var temp = prev.next;
    prev.next = temp;
    this.lenght ++;
    return true;
  }
  remove(index){
    if(index < 0 || index >= this.lenght) return undefined;
    if(index === 0) return this.shift()
    if(index == this.lenght -1) return this.pop();
    var previousNode = this.get(index -1);
    var removed = previousNode.next;
    previousNode.next = removed.next;
    this.lenght --;
    return removed;
  }
}
 

var list = new SinglyLinkedList();
list.push("HELLO");
list.push("world");
list.push("!");
console.log(list);
list.pop();
console.log(list);
list.shift();
console.log(list);
list.unshift(99);
console.log(list);
console.log(list.get(0));
list.set(0, "set");
console.log(list);
list.insert(0,"first");
console.log(list);


