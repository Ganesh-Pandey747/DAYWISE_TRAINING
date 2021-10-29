using System.Collections;
using System.Collections.Generic;
using Collection.Models;
namespace Collection.Taaza
{
    public class Candidatelist
    {
       public ArrayList Candidatedetails()
       {
        
           ArrayList arrayList=new ArrayList();
           arrayList.Add("Salman");
           arrayList.Add("ganesh");
           return arrayList;         
       } 
    
          public  List<candidate> Candidatedetail()
       {
           List<candidate> obj=new List<candidate>();
           obj.Add(new candidate{
               Cid=101,
               Cname="Ganesh pandey"
           });
            obj.Add(new candidate{
               Cid=102,
               Cname="Ganesh"
           });
           return obj;     
       } 
    }
}