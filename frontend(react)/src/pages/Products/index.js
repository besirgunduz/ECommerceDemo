import { Grid } from "@chakra-ui/react";
import { useQuery } from "react-query";

import { fetchProductList } from "../../api";
import Card from "../../components/Card";

function Products() {
  const { isLoading, error, data } = useQuery("products", fetchProductList);
  if (isLoading) return "Loading...";
  if (error) return "An error has occurred: " + error.message;

  return (
    <div>
      <Grid templateColumns="repeat(4,1fr)" gap={4}>
        {data.data.map((item, key) => (
          <Card key={key} item={item} />
        ))}
      </Grid>
    </div>
  );
}

export default Products;
