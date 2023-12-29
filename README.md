# testMELI
Resolución de los ejercicios técnicos evaluados en el proceso de selección.

Challenge #1: Duplicated Products.
You are given a complex list of n products, each with a names, prices, and weights. Find out how many duplicate products are present within the list. Duplicate products contain identical parameters for all fields in the list (i.e. names, prices, and weights).
Example: There are n = 5 products with attributes listed in three arrays, aligned by index.
name = [hat, jacket, shoe, shoe, shoe]
prices = [2, 3, 1, 2, 1]
weights = [2, 5, 1, 1, 1]
A complete item description for item 0: (names[0], prices[0], weights[0]) is (hat, 2, 2).
The first two items are unique. The two shoes at indices 2 and 4 are equal in all three attributes so there is 1 duplicate. The last shoe at index 3 has a different price from the other two, so it is not a duplicate. There is 1 duplicate item in the original list. 
Function Description 
Complete the function numDupProducts in the editor below. The function must return an integer denoting the number of duplicates within the product list. numDupProducts has the following parameter(s): string names[n]: string array of size n, where names[i] denotes the name of the product at the index of i. int prices[n]; int array of size n, where prices[i] denotes the price of the product at the index of i. int weights[n]: int array of size n, where weights[i] denotes the weight of the product at the index of i. 
Complete the 'numDupProducts' function below. The function is expected to return an INTEGER. The function accepts following parameters: 1. STRING_ARRAY names 2. INTEGER_ARRAY prices 3. INTEGER_ARRAY weights.

Challenge #2: Countries by Region.
Use the http get method to retrieve information from a wheather records database. Query https://jsonmock.hackerrank.com/api/countries/search?region={region}&name={keyword} to filter by region and name. The query result is paginated. 
To access additional pages append &page={num} to the url where num is the page number. The query response from the API is a JSON with the following five fields:
page: the current page, 
per_page: the maximun number of results per page, 
total: the total number of records in the search result, 
total_pages: the total number of pages to query in order to get all the results, 
data: an array of json objects containing weather records. 
The data field in the response contains a list of weather recods with the following relevant schema: 
name: the name of the country, region: the region this country belong to, 
population: population of the country. 
Given the region along with a keyword to search in the name field, return a list of string values where each element is the country along with its population, separeted by a comma, and sorted in increasing order of population as shown. If two countries have the same population, sort them further by name. 
Function Description: 
complete the function findCountries, that have the following parameters: 
string keyword: keyword to search for in country name, 
string region: region to search for.
