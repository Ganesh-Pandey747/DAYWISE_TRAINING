//-------------------Observable-----------------------
var pobj = new Promise((resolve, reject) => {
    setTimeout(() => {
        let course = ['EF Core', 'DataBase'];
        let NCourse = ['EF Core', 'DataBase','Opps','c#'];
       // resolve(course); //similar to single circle i.e. return single value
        reject(NCourse);
    }, 2000);
})
//promise is a function that returns single packet that is call resolve
pobj.then((takenFromResolve)=>{
    console.log(`value = `,takenFromResolve);
}).catch((takenFromReject)=>{
    console.log(`value Rejected = `,takenFromReject)
})


//Promise has given well structuredness over callback but there is a complexities in "then"
//To overcome this problem we have async and await.


