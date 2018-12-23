public class Solution {
    public int RomanToInt(string s) {
        char[] charArray = s.ToCharArray();
        char[] symbols = new char[]{'I','V','X','L','C','D','M'};
        int[] values=new int[]{1,5,10,50,100,500,1000};
        Dictionary<char, int> dicValue = new Dictionary<char, int>();
        for(int i=0;i<symbols.Length; ++i)
        {
            dicValue[symbols[i]]=values[i];
        }
        
        bool bAdd = true;
        char prev='I';
        
        int result = 0;
        for(int i=charArray.Length-1; i>=0; --i)
        {
            if(dicValue[charArray[i]]>dicValue[prev])
            {
                bAdd = true;
            }
            else if(dicValue[charArray[i]]<dicValue[prev])
            {
                bAdd = false;
            }
            if(bAdd)
            {
                result+=dicValue[charArray[i]];
            }
            else
            {
                result-=dicValue[charArray[i]];
            }
            prev=charArray[i];
        }
        return result;
    }
}
