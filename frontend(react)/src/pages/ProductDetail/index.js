import { useParams } from "react-router-dom";
import { useQuery } from "react-query";
import { fetchProduct, fetchProductList } from "../../api";
import { Box, Image, Button } from "@chakra-ui/react";
import moment from "moment";
import ImageGallery from "react-image-gallery";

function ProductDetail() {
  const { productid } = useParams();

  const { isLoading, isError, data } = useQuery(["products", productid], () =>
    fetchProduct(productid)
  );

  if (isLoading) {
    return <div>Loading...</div>;
  }

  if (isError) {
    return <div>Error.</div>;
  }

  return (
    <div>
      <Box borderWidth="1px" borderRadius="lg" overflow="hidden" p="3">
        <Image
          src={data.data.picture}
          width={400}
          alt="product"
          loading="lazy"
        />

        <Box p="6">
          <Box mt="1" fontWeight="semibold" as="h4" lineHeight="tight">
            {data.data.name}
          </Box>
          <Box>{data.data.price} TL</Box>
        </Box>
      </Box>
    </div>
  );
}

export default ProductDetail;
