.data
prompt: .asciiz "Enter Value"
sum_message: .asciiz "The sum of integers from 1 to N is: "
.text
main:
 li $v0, 4
    la $a0, prompt
    syscall
li $v0,5 # 1 INPUT
syscall
    # Store the user's input in register $t0.
    move $t0, $v0

 li $t1, 0

    # Start the loop.
loop:
    # Add the current loop iteration to the sum variable.
    add $t1, $t1, $t0

    # Decrement the loop counter.
    sub $t0, $t0, 1

    # Check if the loop counter is equal to zero.
    beq $t0, $zero, end

    # Jump back to the beginning of the loop.
    j loop

end:
    # Print the sum message.
    li $v0, 4
    la $a0, sum_message
    syscall

    # Print the sum of integers from 1 to N.
    move $a0, $t1
    li $v0, 1
    syscall

    # Exit the program.
    li $v0, 10
    syscall
