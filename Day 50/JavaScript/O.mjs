
  import { Observable,of,filter } from 'rxjs';
 
  /* const obs = new Observable((observer) => {
      console.log("Observable starts")
   
      setTimeout(() => { observer.next("1") }, 1000);
      setTimeout(() => { observer.next("2") }, 2000);
      setTimeout(() => { observer.next("3") }, 3000);
      setTimeout(() => { observer.next("4") }, 4000);
      setTimeout(() => { observer.next("5") }, 5000);
      
    }) */



// using "of"  operator
  
//   const obs = of(1,2,3,4,5)
//   function fetchData()
//   {
//       obs.subscribe(val=>{console.log(val)});
//   }
//   fetchData();


// using "filter" operator


const obs = of(1,2,3,4,5)
let case1 = obs.pipe(  
  filter(x => x % 2 === 0)
) 
function fetchData()
{
    case1.subscribe(val=>{console.log(val)});
}
fetchData();