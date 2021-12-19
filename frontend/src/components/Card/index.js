import { Box, Image, Button } from "@chakra-ui/react";
import moment from "moment";
import { Link } from "react-router-dom";

function Card({ item }) {
  return (
    <Box borderWidth="1px" borderRadius="lg" overflow="hidden" p="3">
      <Link to={`/product/${item.id}`}>
        <Image src={item.picture} width={200} alt="product" loading="lazy" />

        <Box p="6">
          <Box mt="1" fontWeight="semibold" as="h4" lineHeight="tight">
            {item.name}
          </Box>
          <Box>{item.price} TL</Box>
        </Box>
      </Link>
    </Box>
  );
}

export default Card;
