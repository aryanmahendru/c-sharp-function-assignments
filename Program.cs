//Functions assignment 

List<int> list = new List<int>{72,3,2,1};
//contains
bool contains(List<int> aList ,int numfind) {
   foreach (int b in aList) {
      if (b == numfind) {
         return true;
      }
   }
   return false;
}

if (contains(list , 2)){
    Console.WriteLine("2 is IN the List");  
}
else{
   Console.WriteLine("2 is not in the list");
}
 


//indexof
int indexof(List<int> cList, int nfind) {
   int indexofnum=-1; 
   for(int c=0;c<cList.Count;c++){
      if (cList[c] == nfind){
         indexofnum = c;
         
      }
   }
return indexofnum;
}

int index = indexof(list,72);
Console.WriteLine("index of number is "+index);



//indexofmin
int indexofmin(List<int> bList){
   int minnumber=list[0];
   int minindex=0;
   for(int p=0;p<bList.Count;p++){
      if(bList[p]<minnumber){
         minnumber=bList[p];
         minindex=p;
      }
   }
   return minindex;
}
Console.WriteLine("index of minimum number is "+indexofmin(list));


//swap
void Swap(List<int> dList,int index77,int index88){
   int number1=dList[index77];
   dList[index77]=dList[index88];
   dList[index88]=number1;
   }
Swap(list,0,1);

for(int h=0;h<list.Count;h++)
Console.WriteLine(list[h]);



//reverse
List<int> reverse(List<int> eList){
   List<int> reversedlist=new List<int>();
   for (int i = eList.Count - 1; i >= 0; i--) {
      reversedlist.Add(eList[i]);
       
   } 
   return reversedlist;
}

List<int> reversednums =reverse(list);
foreach(int item5 in reversednums){
   Console.WriteLine(item5);
}
