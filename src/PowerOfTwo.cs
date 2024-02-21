public class Solution {
    public bool IsPowerOfTwo(int n) {
        if(n <= 0){
            return false;
        }
        if(n == 1 || n == 2 || n == 4){
            return true;
        }
        if(n % 2 == 1){
            return false;
        }
        while(n > 3){
            if(n % 2 == 0){
                n = n / 2;
            }
            else{
                return false;
            }
        }
        if(n % 2 == 1){
            return false;
        }
        else{
            return true;
        }
    }
}