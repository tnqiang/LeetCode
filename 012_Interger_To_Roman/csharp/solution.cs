public class Solution {
    public string IntToRoman(int num) {
        string ret = string.Empty;
        int digitNum=0;
        string[] small=new string[]{"I","X","C","M"};
        string[] large=new string[]{"V","L","D"};
        int negative=0;
        int cross=0;
        
        while(num>0)
        {
            int temp = num%10;
            num=num/10;
            negative = 0;
            
            if(temp==4) 
            {
                temp++;
                negative=1;
            }
            else if(temp==9)
            {
                temp++;
                negative=1;
            }
            
            if(temp>9)
            {
                ret = small[digitNum+1]+ret;
            }
            else
            {
                int largeNum=temp/5;
                int smallNum=temp%5;

                for(int i=0; i<smallNum; ++i) ret = small[digitNum]+ret;
                for(int i=0; i<largeNum; ++i) ret = large[digitNum]+ret;
            }
            for(int i=0; i<negative;++i) ret=small[digitNum]+ret;
            digitNum++;
        }
        
        return ret;
    }
}
