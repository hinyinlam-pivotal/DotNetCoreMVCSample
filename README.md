===Running in PAS===


cd DotNetCoreWebAppSample

cf push



===Docker image for running in PKS===

cd DotNetCoreWebAppSample

docker build -t hin/dotnetcoresample .

docker run -p 8080:80  hin/dotnetcoresample 
