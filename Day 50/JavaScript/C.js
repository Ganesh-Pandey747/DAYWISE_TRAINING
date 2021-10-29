// //callback
// const funA=()=>{
//     console.log(`I am Callback 1`);
//     setTimeout(() => {                          //inbuild callback function
//         console.log(`I take 3 sec to work`);
//     }, 3000);
// }

// const funB=()=>{
//     console.log(`I am Callback 2`);
//     }
// funA();
// funB();





// ***********************************************


//callback              //this is call callback
const funA=(myCallback)=>{
    console.log(`I am Callback 1`);
    setTimeout(() => {                          //inbuild callback function
        console.log(`I take 3 sec to work`);
        myCallback();
    }, 3000);
}
const funB=()=>{
    console.log(`I am Callback 2`);
    }
funA(funB);