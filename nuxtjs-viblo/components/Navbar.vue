<template>
  <div class="navbar_content_icon">
    <div class="navbar_row">
      <div class="navbar_icon_block" @click="clickHandler(1)">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/email.svg" alt="" />
          <!-- <object :data="url + 'email.svg'" type="image/svg+xml"></object> -->
        </div>
      </div>
      <div class="navbar_icon_block" @click="clickHandler(2)">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/phone.svg" alt="" />
        </div>
      </div>
    </div>

    <div class="navbar_row">
      <div class="navbar_icon_block" @click="clickHandler(3)">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/number.svg" alt="" />
        </div>
      </div>
      <div class="navbar_icon_block" @click="clickHandler(4)">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/float.svg" alt="" />
        </div>
      </div>
    </div>

    <div class="navbar_row">
      <div class="navbar_icon_block">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/paragrap.svg" alt="" />
        </div>
      </div>
      <div class="navbar_icon_block">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/calendar.svg" alt="" />
        </div>
      </div>
    </div>

    <div class="navbar_row">
      <div class="navbar_icon_block">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/calendar-time.svg" alt="" />
        </div>
      </div>
      <div class="navbar_icon_block">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/credit-card.svg" alt="" />
        </div>
      </div>
    </div>

    <div class="navbar_row">
      <div class="navbar_icon_block">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/file.svg" alt="" />
        </div>
      </div>
      <div class="navbar_icon_block">
        <div class="navbar_icon_block_item"></div>
      </div>
    </div>
    <div class="line"></div>
    <div class="navbar_row">
      <div class="navbar_icon_block">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/sort.svg" alt="" />
        </div>
      </div>
      <div class="navbar_icon_block">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/todo-list.svg" alt="" />
        </div>
      </div>
    </div>

    <div class="navbar_row">
      <div class="navbar_icon_block">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/checkbox.svg" alt="" />
        </div>
      </div>
      <div class="navbar_icon_block">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/record.svg" alt="" />
        </div>
      </div>
    </div>

    <div class="navbar_row">
      <div class="navbar_icon_block">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/timeline.svg" alt="" />
        </div>
      </div>
      <div class="navbar_icon_block">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/location.svg" alt="" />
        </div>
      </div>
    </div>

    <div class="navbar_row">
      <div class="navbar_icon_block">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/compact-square.svg" alt="" />
        </div>
      </div>
      <div class="navbar_icon_block">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/compact-cicle.svg" alt="" />
        </div>
      </div>
    </div>

    <div class="navbar_row">
      <div class="navbar_icon_block">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/ratting.svg" alt="" />
        </div>
      </div>
    </div>
    <div class="line"></div>
    <div class="navbar_row">
      <div class="navbar_icon_block">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/heading.svg" alt="" />
        </div>
      </div>
      <div class="navbar_icon_block">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/quote.svg" alt="" />
        </div>
      </div>
    </div>

    <div class="navbar_row">
      <div class="navbar_icon_block">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/image-file.svg" alt="" />
        </div>
      </div>
      <div class="navbar_icon_block">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/film-file.svg" alt="" />
        </div>
      </div>
    </div>
  </div>
</template>
<script>
import { SVG_PATH } from "../static/common.js";
import { v4 as uuidv4 } from "uuid";
export default {
  data() {
    return {
      url: SVG_PATH,
    };
  },
  methods: {
    clickHandler(number) {
      let newItem = {};
      switch (number) {
        case 1:
          newItem = {
            id: uuidv4(),
            path: "../_nuxt/assets/images/email.svg",
            name: "Email",
            type: 1,
            title: "Email",
            subtitle: "",
            description:
              "In this example, we use v-slot to assign content to the header ",
            property: {},
            is_create: true,
          };
          break;
        case 2:
          newItem = {
            id: uuidv4(),
            path: "../_nuxt/assets/images/phone.svg",
            name: "Phone",
            type: 2,
            title: "Phone Number",
            subtitle: "",
            description:
              "In this example, we use v-slot to assign content to the header ",
            property: {},
            is_create: true,
          };
          break;
        case 3:
          newItem = {
            id: uuidv4(),
            path: "../_nuxt/assets/images/timeline.svg",
            name: "Number",
            type: 3,
            title: "Number",
            subtitle: "",
            description:
              "In this example, we use v-slot to assign content to the header ",
            required: false,
            validate: {
              max_value: 5,
              min_value: 0,
            },
            properties: {
              step: 1,
            },
            is_create: true,
          };
          break;
        case 4:
          newItem = {
            id: uuidv4(),
            path: "../_nuxt/assets/images/float.svg",
            name: "Float",
            type: 4,
            title: "Float",
            subtitle: "",
            description:
              "In this example, we use v-slot to assign content to the header ",
            property: {},
            is_create: true,
          };
          break;
        case 5:
          newItem = { path: "../_nuxt/assets/images/email.svg", name: "email" };
          break;
        case 6:
          newItem = { path: "../_nuxt/assets/images/email.svg", name: "email" };
      }
      this.$emit("add-item", newItem);
    },
  },
};
</script>
<style scoped>
.navbar_content_icon {
  display: flex;
  flex-direction: column;
  align-items: flex-start;
  padding: 8px;
  gap: 8px;
  position: absolute;
  width: 88px;
  height: 504px;
  left: 322px;
  /* top: 0px; */

  background: linear-gradient(360deg, #6782df 0%, #29b8e9 100%);
  /* s1 vnform */

  box-shadow: 0px 2px 60px rgba(0, 55, 95, 0.07);
  border-radius: 8px;

  /* Inside auto layout */

  flex: none;
  order: 2;
  flex-grow: 0;
  z-index: 2;
}
.navbar_row {
  display: flex;
  flex-direction: row;
  justify-content: center;
  align-items: center;
  padding: 0px;
  gap: 8px;
  width: 72px;
  height: 32px;

  /* Inside auto layout */

  flex: none;
  order: 0;
  flex-grow: 0;
  position: relative;
}
.navbar_icon {
  width: 32px;
  height: 32px;

  /* Inside auto layout */

  flex: none;
  order: 0;
  flex-grow: 0;
}
.navbar_icon_block_item {
  cursor: pointer;
}
.navbar_icon_block_item:hover svg path {
  fill: #000;
}
.line {
  width: 69px;
  height: 0px;
  border: 1px solid rgba(255, 255, 255, 0.24);
}
</style>
