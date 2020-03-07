#!/usr/bin/python3

from googlesearch import search
import urllib
from urllib.request import urlopen
from bs4 import BeautifulSoup

def google_scrape_body(url):
	thepage = urllib.request.urlopen(url)
	soup = BeautifulSoup(thepage, "html.parser")
	return str(dir(soup))


def google_scrape(url):
    thepage = urllib.request.urlopen(url)
    soup = BeautifulSoup(thepage, "html.parser")
    return soup.title.text

websites_to_search = ['stackoverflow.com','reddit.com','quora.com', 'en.wikipedia.org']

for site in websites_to_search:
	i = 1
	query = 'web scraper python site:' + site
	for url in search(query, stop=2):
		try:
			a = google_scrape(url)
		except:
			print("Error in url " + url)
			a = '\n'
			break
		
		print(str(i) + ". " + a)
		print(url)
		print(" ")
		i += 1