
//callback hell             //this is call callback hell
//callback hell is use of  many callback

const ganesh = () => {
    setTimeout(() => {
        console.log(`I am going to (Nehru Place) after my work, I will callback you`);
        setTimeout(() => {
            console.log(`Done with installation !! and Now, I am going to call Keshav `);
            setTimeout(() => {
                console.log(`Thankyou !! ,I got a laptop and i am going to do Payement of 4000`);
            }, 4000);
        }, 2000);
    }, 5000);
}
ganesh();//5->2->4
