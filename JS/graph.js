class Graph {
  constructor(){
    this.adjacencyList = {};
  }
  addVertex(vertex){
    if(!this.adjacencyList[vertex]){
      this.adjacencyList[vertex] = [];
    }
  }
  addEdge(v1, v2){
    this.adjacencyList[v1].push(v2);
    this.adjacencyList[v2].push(v1);
  }
  removeEdge(vertex1, vertex2){
    this.adjacencyList[vertex1] = this.adjacencyList[vertex1].filter(
      v => v != vertex2
    );
    this.adjacencyList[vertex2] = this.adjacencyList[vertex2].filter(
      v => v !== vertex1
    );
  }
  removeVertex(vertex){
      while(this.adjacencyList[vertex].length){
        const adjacentVertex = this.adjacencyList[vertex].pop();
        this.removeEdge(vertex, adjacentVertex);
      }
      delete this.adjacencyList[vertex];
    }
  depthFirstRecurcive(start){
    const result = [];
    const visited = {};
    const adjacencyList = this.adjacencyList;
    (function dfs(vertex){
      if(!vertex) return null;
      visited[vertex] = true;
      result.push(vertex);
      adjacencyList[vertex].forEach(neighbor => {
        if(!visited[neighbor]){
          return dfs(neighbor);
        }
      });
    })(start)
    return result;
  }
  deapthFirstIterative(start){
    const result = [];
    const stack = [start];
    const visited = {};
    visited[start] = true;
    while(stack.length){
      let currentVertex = stack.pop();
      result.push(currentVertex);
      this.adjacencyList[currentVertex].forEach(neighbor => {
        if(!visited[neighbor]){
          visited[neighbor] = true;
          stack.push(neighbor);
        }
      })
    }
    return result;
  }
}

let g = new Graph();
g.addVertex("Tokyo");
g.addVertex("Dallas");
g.addVertex("Aspen");
g.addEdge("Dallas", "Tokyo");
g.addEdge("Dallas", "Aspen");

console.log(g);

g.removeEdge("Dallas", "Tokyo");
g.removeEdge("Aspen", "Dallas");
console.log(g);
g.removeVertex("Aspen");
console.log(g);
let gDfs = new Graph();
gDfs.addVertex("A");
gDfs.addVertex("B");
gDfs.addVertex("C");
gDfs.addVertex("D");
gDfs.addVertex("E");
gDfs.addVertex("F");

gDfs.addEdge("A", "B");
gDfs.addEdge("A", "C");
gDfs.addEdge("B", "D");
gDfs.addEdge("C", "E");
gDfs.addEdge("D", "E");
gDfs.addEdge("D", "F");
gDfs.addEdge("E", "F");


//        A
//      /    \
//     B      C
//     |      |
//     D-----E
//      \   /
//        F
//

console.log(gDfs.depthFirstRecurcive("A"));
console.log(gDfs.deapthFirstIterative("A"));


