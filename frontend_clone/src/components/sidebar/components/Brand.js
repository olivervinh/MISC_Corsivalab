import React from "react";
// Chakra imports
import { Flex, useColorModeValue } from "@chakra-ui/react";
import LogoCorsivalab from "../../../assets/img/logo/corsivalab.png"
// Custom components
import { HorizonLogo } from "components/icons/Icons";
import { HSeparator } from "components/separator/Separator";

export function SidebarBrand() {
  //   Chakra color mode
  let logoColor = useColorModeValue("navy.700", "white");

  return (
    <Flex align='center' direction='column'>
      <img style={{
        width:"5rem",
        height:"5rem",
      }} src={LogoCorsivalab}></img>
    </Flex>
  );
}

export default SidebarBrand;
