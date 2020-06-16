import math


def encryption(s):
    countString = s.replace(" ", "")
    count = math.sqrt(len(countString))
    col = math.ceil(count)
    row = int(count)

    output = ""
    k = 0
    for i in range(col):
        for j in range(0 + k, len(countString), col):
            output += countString[j]
        k += 1
        output += " "
    return output


if __name__ == '__main__':
    s = input()

    result = encryption(s)

    print(result)
