Feature: SearchCommunity
	Inorder to find a community, user have to search with community name


Scenario Outline: Search a community as a guest
Given Open Browser'<Browser>' and navigate to Emblim website
When search a community with community name contain '<communityName>'
Then i should see the community'<ExpectedCommunityName>' in my result
Examples: 
| communityName | ExpectedCommunityName | Browser |
| Test          | Test                  | firefox  |



