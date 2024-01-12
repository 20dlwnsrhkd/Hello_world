namespace C_SHARP_PROJECT;
public class DAY2_PROGRAM17_2{
    static void Main17_2(String []args){
        string[] name_arry =["아저씨", "김새나", "엄마", "아빠", "누나", "형", "동생", "김말아유", "홍길동", "개구리"];
        string name_input = Console.ReadLine();
        int result = 20;
        for(int i=0; i<10;i++){
            if(name_arry[i]==name_input){
                result=i;
            }
        }
        if (result<10){
            Console.WriteLine("{0}의 위치는 {1}에 숨어있습니다.",name_input,result+1);
        }
        else{
            Console.WriteLine("{1}은 존재하지 않습니다.",name_input);


        }
    }
}