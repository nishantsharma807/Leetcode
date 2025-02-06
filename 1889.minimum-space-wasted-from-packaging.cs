/*
 * @lc app=leetcode id=1889 lang=csharp
 *
 * [1889] Minimum Space Wasted From Packaging
 */

// @lc code=start
public class Solution {    
    private readonly int _mod = 1_000_000_007;

    public int MinWastedSpace(int[] packages, int[][] boxes) {
        long result = long.MaxValue;
        long totalPackagesSpace = packages.Sum(x => (long) x);
        Array.Sort(packages);

        foreach(var supplierBoxes in boxes) {
            Array.Sort(supplierBoxes);
            long totalSpaceUsed = 0;
            int prevPackageIndex = 0;

            if(packages[packages.Length - 1] > supplierBoxes[supplierBoxes.Length - 1]) continue;

            foreach(var box in supplierBoxes) {
                //Check if smallest package fits in the box
                if(packages[0] > box) continue;

                //Find first index of the package that does not fit in the box
                int firstUnfitPackageIndex = FindUpperBound(packages, box);
                int numOfPackagesFit = firstUnfitPackageIndex - prevPackageIndex;

                long spaceUsed = (long) numOfPackagesFit * (long) box;
                totalSpaceUsed += spaceUsed;

                // Move to the next unprocessed package
                prevPackageIndex = firstUnfitPackageIndex;
                // If all packages are placed, break
                if(prevPackageIndex >= packages.Length) break;
            }

            long waste = totalSpaceUsed - totalPackagesSpace;
            result = Math.Min(waste, result);
        }

        return result == long.MaxValue ? -1 : (int)(result % _mod);
    }

    private int FindUpperBound(int[] packages, int box) {
        int left = 0, right = packages.Length;

        while(left < right) {
            int mid = left + (right - left) / 2;

            if(packages[mid] > box) {                
                right = mid;
            } else {
                left = mid + 1;
            }
        }

        return left;
    }
}
// @lc code=end

