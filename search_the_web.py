#!/usr/bin/python3

# docs: https://python-googlesearch.readthedocs.io/en/latest/

from googlesearch import search
import urllib
from urllib.request import urlopen
from bs4 import BeautifulSoup
import os

links = []
query = 'neural networks natural image processing site:'

websites_to_search = ['stackoverflow.com','reddit.com','quora.com', 'en.wikipedia.org', ' '] # ' ' means we also do a simple, general google search
websites__to_search_simple = ['stackoverflow.com']

websites_to_search_long = 	['stackoverflow.com',
							 'reddit.com', 
							 'sitepoint.com', 
							 'codeproject', 
							 'treehouse', 
							 'hackernews', 
							 'github.com']

def google_scrape_body(url):
	thepage = urllib.request.urlopen(url)
	soup = BeautifulSoup(thepage, "html.parser")
	return str(dir(soup))
	
def google_scrape(url):
    thepage = urllib.request.urlopen(url)
    soup = BeautifulSoup(thepage, "html.parser")
    return soup.title.text



# The actual google search happens here:

"""
googlesearch.search(query, tld='com', lang='en', tbs='0', safe='off', num=10, start=0, stop=None, domains=None, pause=2.0, tpe='', country='', extra_params=None, user_agent=None)


query (str) – Query string. Must NOT be url-encoded.
tld (str) – Top level domain.
lang (str) – Language.
tbs (str) – Time limits (i.e “qdr:h” => last hour, “qdr:d” => last 24 hours, “qdr:m” => last month).
safe (str) – Safe search.
num (int) – Number of results per page.
start (int) – First result to retrieve.
stop (int) – Last result to retrieve. Use None to keep searching forever.
domains (list) – A list of web domains to constrain the search.
pause (float) – Lapse to wait between HTTP requests. A lapse too long will make the search slow, but a lapse too short may cause Google to block your IP. Your mileage may vary!
tpe (str) – Search type (images, videos, news, shopping, books, apps) Use the following values {videos: ‘vid’, images: ‘isch’, news: ‘nws’, shopping: ‘shop’, books: ‘bks’, applications: ‘app’}
country (str) – Country or region to focus the search on. Similar to changing the TLD, but does not yield exactly the same results. Only Google knows why…
extra_params (dict) – A dictionary of extra HTTP GET parameters, which must be URL encoded. For example if you don’t want Google to filter similar results you can set the extra_params to {‘filter’: ‘0’} which will append ‘&filter=0’ to every query.
user_agent (str) – User agent for the HTTP requests. Use None for the default

"""
f = open("guru99.txt" ,"w+")

for site in websites_to_search:
	i = 1
	query += site
	for url in search(query, stop=2):
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

		f.write(str(i) + ". " + a + os.linesep)
		f.write(url + os.linesep + os.linesep)
		i += 1

f.close()