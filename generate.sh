#!/bin/sh
SOURCE_OUTPUT_DIR="./samples/client/coface"
DOC_OUTPUT_DIR="./samples/docs/client/coface"
rm -rf SOURCE_OUTPUT_DIR
rm -rf DOC_OUTPUT_DIR

# Generate source code
java -jar modules/swagger-codegen-cli/target/swagger-codegen-cli.jar generate \
  -i ./open-api/coface.yaml \
  -l kotlin-server \
  -o "${SOURCE_OUTPUT_DIR}" \
  -t templates/kotlin-client \


# Generate doc
java -jar modules/swagger-codegen-cli/target/swagger-codegen-cli.jar generate \
  -i ./open-api/coface.yaml \
  -l html \
  -o "${DOC_OUTPUT_DIR}" \

