class PriorityQueue{
  constructor(){
    this.values = [];
  }
  enqueue(val, priority){
    this.values.push({val, priority});
    this.sort();
  };
  dequeue(){
    return this.values.shift();
  };
  sort(){
    this.values.sort((a,b)=> a.priority - b.priority);
    
  };
}
class WeightedGraph{
  constructor(){
    this.adjacencyList = {};
  }
  addVertex(vertex){
    if(!this.adjacencyList[vertex]){
      this.adjacencyList[vertex] = [];
    }
  }
  addEdge(v1, v2, weight){
    this.adjacencyList[v1].push({node:v2, weight});
    this.adjacencyList[v2].push({node:v1, weight});
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
  Dijkstra(start, finish){
    const nodes = new PriorityQueue();
    const distances = {};
    const previus = {};
    let path = []; // to return at the end
    let smallest;
    // build up initial state
    for(let vertex in this.adjacencyList){
      if(vertex === start){
        distances[vertex] = 0;
        nodes.enqueue(vertex, 0);
      }else{
        distances[vertex] = Infinity;
        nodes.enqueue(vertex, Infinity);
      }
      previus[vertex] = null;
    }
    // as long as there is something to visited
    while(nodes.values.length){
        smallest = nodes.dequeue().val;
        if(smallest === finish){
        //We are done
        //build up path to return at end
        while(previus[smallest]){
          path.push(smallest);
          smallest = previus[smallest];
        }
        break;

      }
    
      if(smallest || distances[smallest] !== Infinity){
        for(let neighbor in this.adjacencyList[smallest]){
          let nextNode = this.adjacencyList[smallest][neighbor];
          let candidate = distances[smallest] + nextNode.weight;
          let nextNeighbor = nextNode.node;
          if(candidate < distances[nextNeighbor]){
            distances[nextNeighbor] = candidate;
            previus[nextNeighbor] = smallest;
            nodes.enqueue(nextNeighbor, candidate);
          }
        }
      }
    } 
   
    return path.concat(smallest).reverse();
    
  }
}

let graph = new WeightedGraph();
graph.addVertex("A");
graph.addVertex("B");
graph.addVertex("C");
graph.addVertex("D");
graph.addVertex("E");
graph.addVertex("F");

graph.addEdge("A", "B", 4);
graph.addEdge("A", "C", 2);
graph.addEdge("B", "C", 3);
graph.addEdge("C", "D", 2);
graph.addEdge("C", "F", 4);
graph.addEdge("D", "E", 3);
graph.addEdge("D", "F", 1);
graph.addEdge("E", "F", 1);

console.log(graph.Dijkstra("A", "E"));
