.data
prompt:     .asciiz "Enter an integer: "
result:     .asciiz "The largest number is: "
newline:    .asciiz "\n"

.text
.globl main

main:
    # Prompt the user to enter the first integer
    li $v0, 4
    la $a0, prompt
    syscall

    # Read the first integer from the user
    li $v0, 5
    syscall
    move $t0, $v0  # Store the first integer in $t0

    # Prompt the user to enter the second integer
    li $v0, 4
    la $a0, prompt
    syscall

    # Read the second integer from the user
    li $v0, 5
    syscall
    move $t1, $v0  # Store the second integer in $t1

    # Prompt the user to enter the third integer
    li $v0, 4
    la $a0, prompt
    syscall

    # Read the third integer from the user
    li $v0, 5
    syscall
    move $t2, $v0  # Store the third integer in $t2

    # Find the largest of the three integers
    # Compare the first two numbers and store the larger one in $t3
    bgt $t0, $t1, find_largest
    move $t3, $t1
    j compare_t3_t2

find_largest:
    move $t3, $t0

compare_t3_t2:
    # Compare the largest number with the third number and store the largest in $t3
    bgt $t3, $t2, print_result
    move $t3, $t2

print_result:
    # Print the result
    li $v0, 4
    la $a0, result
    syscall

    # Print the largest number
    li $v0, 1
    move $a0, $t3
    syscall

    # Print a newline character
    li $v0, 4
    la $a0, newline
    syscall

    # Exit the program
    li $v0, 10
    syscall
