package main

import "fmt"

func main() {
	fmt.Println(isMonotonic([]int{1, 2, 2, 3}))
	fmt.Println(isMonotonic([]int{6, 5, 4, 4}))
	fmt.Println(isMonotonic([]int{1, 3, 2}))
}

func isMonotonic(nums []int) bool {
	isIncreasing := false
	isDecreasing := false

	for i := 0; i < len(nums)-1; i++ {
		if nums[i] < nums[i+1] {
			isIncreasing = true
		}

		if nums[i] > nums[i+1] {
			isDecreasing = true
		}
	}

	return isIncreasing && isDecreasing
}
