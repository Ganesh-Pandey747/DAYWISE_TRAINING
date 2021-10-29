using System;
using Collection.Taaza;
using System.Collections;

namespace Collection
{
    class Program
    {
        static void Main()
        {
           /*  var obj=new Candidatelist();
            var arrayList=obj.Candidatedetails();
            int count=arrayList.Count;
            for(int i=0;i<count;i++)
            {
                Console.WriteLine(arrayList[i]);
            }  */
             var objlist=new Candidatelist();
            var List=objlist.Candidatedetail();
            int count=List.Count;
            for(int i=0;i<count;i++)
            {
                Console.WriteLine(List[i].Cid+"  " +List[i].Cname);
            } 


           
        }
    }
}