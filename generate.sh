#!/bin/sh
OUTPUT_DIR="./samples/client/coface"

rm -rf samples/client/coface
java -jar modules/swagger-codegen-cli/target/swagger-codegen-cli.jar generate \
  -i ./open-api/coface.yaml \
  -l kotlin-server \
  -o "${OUTPUT_DIR}" \
  -t templates/kotlin-client
