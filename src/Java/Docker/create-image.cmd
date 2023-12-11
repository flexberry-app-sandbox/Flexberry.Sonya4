docker build --no-cache -f SQL\Dockerfile.PostgreSql -t sonya4-java/postgre-sql ../../SQL

docker build --no-cache -f Dockerfile -t sonya4-java/app ../../..
