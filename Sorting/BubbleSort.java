//O(n^2)
class Solution {
    public static List<Integer> sortList(List<Integer> unsortedList) {
        int n = unsortedList.size();
        for (int i = n - 1; i >= 0; i--) {
            boolean swapped = false;
            for (int j = 0; j < i; j++) {
                if (unsortedList.get(j) > unsortedList.get(j + 1)) {
                    int temp = unsortedList.get(j);
                    unsortedList.set(j, unsortedList.get(j + 1));
                    unsortedList.set(j + 1, temp);
                    swapped = true;
                }
            }
            if (!swapped)
                return unsortedList;
        }
        return unsortedList;
    }
