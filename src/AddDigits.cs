public class Solution {
    public int AddDigits(int num) {
        int n = 0;
        while(true){
            while(num != 0){
                n += num % 10;
                num = num / 10;
            }
            if(n < 10){
                return n;
            }
            num = n;
            n = 0;
        }
    }
}