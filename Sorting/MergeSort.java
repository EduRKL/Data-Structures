//O(nlog(n)) - recursion
class Solution {
    public static List<Integer> sortListInterval(List<Integer> unsortedList, int start, int end) {
        if (end - start <= 1) {
            return unsortedList.subList(start, end);
        }
        int midpoint = (start + end) / 2;
        List<Integer> leftList = sortListInterval(unsortedList, start, midpoint);
        List<Integer> rightList = sortListInterval(unsortedList, midpoint, end);
        ArrayList<Integer> resultList = new ArrayList<>();
        int leftPointer = 0, rightPointer = 0;
        while (leftPointer < leftList.size() || rightPointer < rightList.size()) {
            if (leftPointer == leftList.size()) {
                resultList.add(rightList.get(rightPointer));
                rightPointer++;
            } else if (rightPointer == rightList.size()) {
                resultList.add(leftList.get(leftPointer));
                leftPointer++;
            } else if (leftList.get(leftPointer) <= rightList.get(rightPointer)) {
                resultList.add(leftList.get(leftPointer));
                leftPointer++;
            } else {
                resultList.add(rightList.get(rightPointer));
                rightPointer++;
            }
        }
        return resultList;
    }