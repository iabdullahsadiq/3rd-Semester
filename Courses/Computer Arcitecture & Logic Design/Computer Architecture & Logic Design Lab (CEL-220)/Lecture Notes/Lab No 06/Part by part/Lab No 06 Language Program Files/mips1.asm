# AND
li $t1,0b1010
li $t1, 0b1100
and $t2, $t0, $t1
# Output: $t2 contains 0b1000

# OR
li $t0, 0b1010
li $t1, 0b1100
or $t2, $t0, $t1
# Output: $t2 contains 0b1110

# NOT
li $t0, 0b1010
not $t2, $t0
# Output: $t2 contains -0b1011

# XOR
li $t0, 0b1010
li $t1, 0b1100
xor $t2, $t0, $t1
# Output: $t2 contains 0b0110

# XNOR
li $t0, 0b1010
li $t1, 0b1100
xor $t2, $t0, $t1
not $t2, $t2
# Output: $t2 contains -0b1001

# NOR
li $t0, 0b1010
li $t1, 0b1100
nor $t2, $t0, $t1
# Output: $t2 contains -0b1111

# NAND
li $t0, 0b1010
li $t1, 0b1100
and $t2, $t0, $t1
nor $t2, $t2, $zero
# Output: $t2 contains -0b1111
