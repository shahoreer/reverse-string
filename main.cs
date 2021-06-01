// reverse a sentence or string

using System;
class HelloWorld {
  static void Main() {
    string sentence="sup bros?";
    Console.Write(reversestg(sentence));
  }
  
   static string reversestg(string sentc){
   string retst=""; // return string
   
   int length= sentc.Length;
   
   for(int i=0;i<length;i++){
        retst+=sentc.Substring(length-1-i,1);
   }
   
   return retst;
  }
}
