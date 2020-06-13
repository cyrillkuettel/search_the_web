#!/usr/bin/python3

# docs: https://python-googlesearch.readthedocs.io/en/latest/
# [very important] installing the googlesearch module : pip install google NOT 'googlesearch'
from googlesearch import search
import urllib
from urllib.request import urlopen
from bs4 import BeautifulSoup
import sys
links = []
query = 'neural networks natural image processing'
websites_to_search = ['stackoverflow.com','reddit.com','quora.com', 'en.wikipedia.org', ' ']

query = sys.argv[1]
websites_to_search = sys.argv[2:]

def google_scrape_body(url):
	thepage = urllib.request.urlopen(url)
	soup = BeautifulSoup(thepage, "html.parser")
	return str(dir(soup))	
def google_scrape(url):
    thepage = urllib.request.urlopen(url)
    soup = BeautifulSoup(thepage, "html.parser")
    return soup.title.text

#  argv[1] =  query
# everything else should be in the array websites_to_search




# The actual google search happens here:
query += " site:"
#zwischenspeicher
q = query

for site in websites_to_search:
	i = 1
	query = q
	query += site
	for url in search(query, stop=5):
		links.append(url)
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