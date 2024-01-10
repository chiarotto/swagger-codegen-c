/*
 * Swagger Petstore
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package io.swagger.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import android.os.Parcelable;
import android.os.Parcel;
/**
 * FakeJsonFormDataBody
 */


public class FakeJsonFormDataBody implements Parcelable {
  @SerializedName("param")
  private String param = null;

  @SerializedName("param2")
  private String param2 = null;

  public FakeJsonFormDataBody() {
  }
  public FakeJsonFormDataBody param(String param) {
    this.param = param;
    return this;
  }

   /**
   * field1
   * @return param
  **/
  @Schema(required = true, description = "field1")
  public String getParam() {
    return param;
  }

  public void setParam(String param) {
    this.param = param;
  }

  public FakeJsonFormDataBody param2(String param2) {
    this.param2 = param2;
    return this;
  }

   /**
   * field2
   * @return param2
  **/
  @Schema(required = true, description = "field2")
  public String getParam2() {
    return param2;
  }

  public void setParam2(String param2) {
    this.param2 = param2;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    FakeJsonFormDataBody fakeJsonFormDataBody = (FakeJsonFormDataBody) o;
    return Objects.equals(this.param, fakeJsonFormDataBody.param) &&
        Objects.equals(this.param2, fakeJsonFormDataBody.param2);
  }

  @Override
  public int hashCode() {
    return Objects.hash(param, param2);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class FakeJsonFormDataBody {\n");
    
    sb.append("    param: ").append(toIndentedString(param)).append("\n");
    sb.append("    param2: ").append(toIndentedString(param2)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }


  public void writeToParcel(Parcel out, int flags) {
    out.writeValue(param);
    out.writeValue(param2);
  }

  FakeJsonFormDataBody(Parcel in) {
    param = (String)in.readValue(null);
    param2 = (String)in.readValue(null);
  }

  public int describeContents() {
    return 0;
  }

  public static final Parcelable.Creator<FakeJsonFormDataBody> CREATOR = new Parcelable.Creator<FakeJsonFormDataBody>() {
    public FakeJsonFormDataBody createFromParcel(Parcel in) {
      return new FakeJsonFormDataBody(in);
    }
    public FakeJsonFormDataBody[] newArray(int size) {
      return new FakeJsonFormDataBody[size];
    }
  };
}
