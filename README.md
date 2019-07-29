# This is an excercise with examples for devops practice. 
If you are able to set up Azure Devops, create the right variables, build, and deploy the contents of the repo (instruction steps below), it will result in a webshop, where if you "buy" something you will actually get it for free. 

# Steps

1.  Make sure you have a Visual Studio Professional subscription	
2.  Create your own active directory and transfer your azure subscription into you directory
3.	Create an Azure Devops instance
4.	Import this git repo into your azure devops name the repo as `GiftShop`
5.	Set up the pipelines and variables, a unique name/url for your web application, and authorize the pipeline tasks with your subscription\
5.i Build pipeline is in the `azure-pipelines.yml` the release pipeline is in the `Assets` folder `Release.json`
6.	Run the pipeline, and check the results
7.  Buy something in your deployed webshop

## Frequent point of failures -> and solutions
1. The app name you provided is already taken -> update your variable and run again
2. The template file or others not found -> if you imported the repo to a different name than `GiftShop` link the artifacts again (build output and repo), and update file paths in all tasks in the release, or start over and import the repo with a good name.