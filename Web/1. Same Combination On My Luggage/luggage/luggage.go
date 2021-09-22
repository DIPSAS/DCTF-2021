package main

import (
	"html/template"
	"net/http"
	"strings"
)

func validateCredentials(username string, password string) bool {
	if strings.ToLower(username) != "admin" {
		return false
	}

	// Allow any variation of the passwords which contain at least one capital and lowercase letter:
	if strings.ToUpper(password) == password {
		return false
	}

	if strings.ToLower(password) == password {
		return false
	}

	// https://www.pcmag.com/news/2020s-most-common-passwords-are-laughably-insecure
	candidates := []string{"password1", "qqww1122", "aaron431", "million2"}
	for _, candidate := range candidates {
		if strings.ToLower(password) == candidate {
			return true
		}
	}

	return false
}

type Contents struct {
	HintComments template.HTML
}

func main() {
	body := Contents{
		HintComments: template.HTML("<!-- <li>Can't be one of the top 20 most popular passwords</li>--><!-- TODO: Can someone explain why admin doesn't want us to exclude all of the common passwords? --><!-- For some reason, admin got very upset when I suggested excluding the top 20... -->"),
	}

	index := template.Must(template.ParseFiles("index.html"))
	wrong := template.Must(template.ParseFiles("wrong.html"))
	correct := template.Must(template.ParseFiles("correct.html"))
	http.HandleFunc("/signin", func(w http.ResponseWriter, r *http.Request) {
		valid := validateCredentials(r.FormValue("username"), r.FormValue("password"))
		if valid {
			correct.Execute(w, nil)
			return
		}

		wrong.Execute(w, body)
	})
	http.HandleFunc("/", func(w http.ResponseWriter, r *http.Request) {
		index.Execute(w, body)
	})

	http.ListenAndServe("0.0.0.0:80", nil)
}
