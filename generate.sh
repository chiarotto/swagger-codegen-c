java -jar modules/swagger-codegen-cli/target/swagger-codegen-cli.jar generate \
  -i https://petstore.swagger.io/v2/swagger.json \
  -l java \
  -o samples/client/petstore/java