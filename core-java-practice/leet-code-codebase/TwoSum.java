import java.util.HashMap;
import java.util.Map;

class TwoSum {
    public int[] twoSum(int[] nums, int target) {
        Map<Integer, Integer> map = new HashMap<>();

        for (int i = 0; i < nums.length; i++) {
            int ele = nums[i];
            int complement = target - ele;

            if (map.containsKey(complement)) {
                return new int[] { i, map.get(complement) };
            } else {
                map.put(ele, i);
            }
        }
      
        return new int[] { -1, -1 };
    }
}