package main

import (
	"fmt"
	"os"
)

func main() {
	for {
		var key string
		fmt.Println("What's the password?")
		_, _ = fmt.Scanln(&key)
		if key == os.Getenv("SECRET_PASSWORD") {
			fmt.Println("Welcome! The flag is")
			fmt.Print("d:ctf{")
			contents, _ := os.ReadFile("/flag-start")
			fmt.Print(string(contents))
			fmt.Print("-")
			fmt.Print(os.Getenv("FLAG_END"))
			fmt.Println("}")
			break
		}
	}
}
