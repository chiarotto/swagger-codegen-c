java -jar modules/swagger-codegen-cli/target/swagger-codegen-cli.jar generate \
  -i ./open-api/coface.yaml \
  -l kotlin-server \
  -o samples/client/coface