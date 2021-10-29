//-------------------async and await-----------------------
var pobj = new Promise((resolve, reject) => {
    setTimeout(() => {
        let course = ['EF Core', 'DataBase'];
        let NCourse = ['EF Core', 'DataBase','Opps','c#'];
       // resolve(course); //similar to single circle i.e. return single value
        resolve(NCourse);
    }, 2000);
})
//promise has given well structureness over callback but their is complexities in "then". to overcome this problem
//we have async and await.
        //----------------

async function getDataFromPromise()
{
    const pc=await pobj;
    console.log(`Value = ${pc}`);
}        
getDataFromPromise();