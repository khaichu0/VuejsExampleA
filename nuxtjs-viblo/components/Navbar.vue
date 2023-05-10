<template>
  <div class="navbar_content_icon">
    <div class="navbar_row">
      <div class="navbar_icon_block" @click="clickHandler(1)">
        <div class="navbar_icon_block_item">
          <img src="~/assets/images/email.svg" alt="" />
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
      <div class="navbar_icon_block" @click="clickHandler(5)">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/paragrap.svg" alt="" />
        </div>
      </div>
      <div class="navbar_icon_block" @click="clickHandler(6)">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/calendar.svg" alt="" />
        </div>
      </div>
    </div>

    <div class="navbar_row">
      <div class="navbar_icon_block" @click="clickHandler(7)">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/calendar-time.svg" alt="" />
        </div>
      </div>
      <div class="navbar_icon_block" @click="clickHandler(8)">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/credit-card.svg" alt="" />
        </div>
      </div>
    </div>

    <div class="navbar_row">
      <div class="navbar_icon_block" @click="clickHandler(9)">
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
      <div class="navbar_icon_block" @click="clickHandler(10)">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/sort.svg" alt="" />
        </div>
      </div>
      <div class="navbar_icon_block" @click="clickHandler(11)">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/todo-list.svg" alt="" />
        </div>
      </div>
    </div>

    <div class="navbar_row">
      <div class="navbar_icon_block" @click="clickHandler(12)">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/checkbox.svg" alt="" />
        </div>
      </div>
      <div class="navbar_icon_block" @click="clickHandler(13)">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/record.svg" alt="" />
        </div>
      </div>
    </div>

    <div class="navbar_row">
      <div class="navbar_icon_block" @click="clickHandler(14)">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/timeline.svg" alt="" />
        </div>
      </div>
      <div class="navbar_icon_block" @click="clickHandler(15)">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/location.svg" alt="" />
        </div>
      </div>
    </div>

    <div class="navbar_row">
      <div class="navbar_icon_block" @click="clickHandler(16)">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/compact-square.svg" alt="" />
        </div>
      </div>
      <div class="navbar_icon_block" @click="clickHandler(17)">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/compact-cicle.svg" alt="" />
        </div>
      </div>
    </div>

    <div class="navbar_row">
      <div class="navbar_icon_block" @click="clickHandler(18)">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/ratting.svg" alt="" />
        </div>
      </div>
    </div>
    <div class="line"></div>
    <div class="navbar_row">
      <div class="navbar_icon_block" @click="clickHandler(19)">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/heading.svg" alt="" />
        </div>
      </div>
      <div class="navbar_icon_block" @click="clickHandler(20)">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/quote.svg" alt="" />
        </div>
      </div>
    </div>

    <div class="navbar_row">
      <div class="navbar_icon_block" @click="clickHandler(21)">
        <div class="navbar_icon_block_item">
          <img src="../assets/images/image-file.svg" alt="" />
        </div>
      </div>
      <div class="navbar_icon_block" @click="clickHandler(22)">
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
            path: "~/assets/images/email.svg",
            name: "Email",
            type: 1,
            type_name:"Email",
            title: "Email",
            subtitle: "",
            description:
              "In this example, we use v-slot to assign content to the header ",
            required: false,
            property: {},
            is_create: true,
            value:""
          };
          break;
        case 2:
          newItem = {
            id: uuidv4(),
            path: "../_nuxt/assets/images/phone.svg",
            name: "Phone",
            type: 2,
            title: "Số điện thoại",
            subtitle: "",
            description:
              "In this example, we use v-slot to assign content to the header ",
            required: false,
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
            title: "Chuỗi số",
            subtitle: "",
            description:
              "In this example, we use v-slot to assign content to the header ",
            required: false,
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
            title: "Chuỗi số thập phân",
            subtitle: "",
            description:
              "In this example, we use v-slot to assign content to the header ",
            required: false,
            property: {},
            is_create: true,
          };
          break;
        case 5:
          newItem = {
            id: uuidv4(),
            path: "../_nuxt/assets/images/paragrap.svg",
            name: "Paragrap",
            type: 5,
            title: "Đoạn văn bản",
            subtitle: "",
            description:
              "In this example, we use v-slot to assign content to the header ",
            required: false,
            property: {
              is_paragraph: true,
            },
            is_create: true,
          };
          break;
        case 6:
          newItem = {
            id: uuidv4(),
            path: "../_nuxt/assets/images/calendar.svg",
            name: "Calendar",
            type: 6,
            title: "Ngày",
            subtitle: "",
            description:
              "In this example, we use v-slot to assign content to the header ",
            required: false,
            property: {},
            is_create: true,
          };
          break;
        case 7:
          newItem = {
            id: uuidv4(),
            path: "../_nuxt/assets/images/calendar.svg",
            name: "CalendarTime",
            type: 7,
            title: "Ngày giờ",
            subtitle: "",
            description:
              "In this example, we use v-slot to assign content to the header ",
            required: false,
            property: {},
            is_create: true,
          };
          break;
        case 8:
          newItem = {
            id: uuidv4(),
            path: "../_nuxt/assets/images/calendar.svg",
            name: "Credit",
            type: 8,
            title: "Căn cước công dân",
            subtitle: "",
            description:
              "In this example, we use v-slot to assign content to the header ",
            required: false,
            property: {},
            is_create: true,
          };
          break;
        case 9:
          newItem = {
            id: uuidv4(),
            path: "../_nuxt/assets/images/calendar.svg",
            name: "File",
            type: 9,
            title: "Tệp đính kèm",
            subtitle: "",
            description:
              "In this example, we use v-slot to assign content to the header ",
            required: false,
            property: {},
            is_create: true,
          };
          break;
        case 10:
          newItem = {
            id: uuidv4(),
            path: "../_nuxt/assets/images/sort.svg",
            name: "SelectOption",
            type: 10,
            title: "Menu thả xuống",
            subtitle: "",
            description:
              "In this example, we use v-slot to assign content to the header ",
            required: false,
            property: {
              options: [
                {
                  id: 1,
                  type: "text",
                  label: "Lựa chọn 1",
                  value: 1,
                },
              ],
            },
            is_create: true,
          };
          break;
        case 11:
          newItem = {
            id: uuidv4(),
            path: "../_nuxt/assets/images/calendar.svg",
            name: "Votting",
            type: 11,
            title: "Biểu quyết",
            subtitle: "",
            description:" ",
            required: false,
            property: {
              options: [
                {
                  id: 1,
                  type: "text",
                  label: "Lựa chọn 1",
                  value: 1,
                },
              ]
            },
            is_create: true,
          };
          break;
        case 12:
          newItem = {
            id: uuidv4(),
            path: "../_nuxt/assets/images/calendar.svg",
            name: "Checkbox",
            type: 12,
            title: "Hộp kiểm",
            subtitle: "",
            description:
              "In this example, we use v-slot to assign content to the header ",
            required: false,
            property: {
              "arranged": "vertical",
            "options": [
              {
                "id": 1,
                "type": "text",
                "data": "Lựa chọn 1"
              },
            ]
            },
            is_create: true,
          };
          break;
        case 13:
          newItem = {
            id: uuidv4(),
            path: "../_nuxt/assets/images/calendar.svg",
            name: "Radio",
            type: 13,
            title: "Trắc nghiệm",
            subtitle: "",
            description:
              "In this example, we use v-slot to assign content to the header ",
            required: false,
            property: {},
            is_create: true,
          };
          break;
        case 14:
          newItem = {
            id: uuidv4(),
            path: "../_nuxt/assets/images/calendar.svg",
            name: "Linear Range",
            type: 14,
            title: "Phạm vi tuyến tính",
            subtitle: "",
            description:
              "In this example, we use v-slot to assign content to the header ",
            required: false,
            property: {},
            is_create: true,
          };
          break;
        case 15:
          newItem = {
            id: uuidv4(),
            path: "../_nuxt/assets/images/calendar.svg",
            name: "Location",
            type: 15,
            title: "Địa chỉ",
            subtitle: "",
            description:
              "In this example, we use v-slot to assign content to the header ",
            required: false,
            property: {},
            is_create: true,
          };
          break;
        case 16:
          newItem = {
            id: uuidv4(),
            path: "../_nuxt/assets/images/calendar.svg",
            name: "Checkbox Grid",
            type: 16,
            title: "Lưới hộp kiểm",
            subtitle: "",
            description:
              "In this example, we use v-slot to assign content to the header ",
            required: false,
            property: {},
            is_create: true,
          };
          break;
        case 17:
          newItem = {
            id: uuidv4(),
            path: "../_nuxt/assets/images/calendar.svg",
            name: "Radio Grid",
            type: 17,
            title: "Lưới trắc nghiệm",
            subtitle: "",
            description:
              "In this example, we use v-slot to assign content to the header ",
            required: false,
            property: {},
            is_create: true,
          };
          break;
        case 18:
          newItem = {
            id: uuidv4(),
            path: "../_nuxt/assets/images/calendar.svg",
            name: "Ratting",
            type: 18,
            title: "Đánh giá",
            subtitle: "",
            description:
              "In this example, we use v-slot to assign content to the header ",
            required: false,
            property: {},
            is_create: true,
          };
          break;
        case 19:
          newItem = {
            id: uuidv4(),
            path: "../_nuxt/assets/images/calendar.svg",
            name: "Heading",
            type: 19,
            title: "Tiêu đề",
            subtitle: "",
            description:
              "In this example, we use v-slot to assign content to the header ",
            required: false,
            property: {},
            is_create: true,
          };
          break;
        case 20:
          newItem = {
            id: uuidv4(),
            path: "../_nuxt/assets/images/calendar.svg",
            name: "Quote",
            type: 20,
            title: "Trích dẫn",
            subtitle: "",
            description:
              "In this example, we use v-slot to assign content to the header ",
            required: false,
            property: {},
            is_create: true,
          };
          break;
        case 21:
          newItem = {
            id: uuidv4(),
            path: "../_nuxt/assets/images/calendar.svg",
            name: "Image file",
            type: 21,
            title: "Tệp ảnh",
            subtitle: "",
            description:
              "In this example, we use v-slot to assign content to the header ",
            required: false,
            property: {},
            is_create: true,
          };
          break;
        case 22:
          newItem = {
            id: uuidv4(),
            path: "../_nuxt/assets/images/calendar.svg",
            name: "Video file",
            type: 22,
            title: "Tệp video ",
            subtitle: "",
            description:
              "In this example, we use v-slot to assign content to the header ",
            required: false,
            property: {},
            is_create: true,
          };
          break;
        case 23:
          newItem = {
            id: uuidv4(),
            path: "../_nuxt/assets/images/calendar.svg",
            name: "Calendar",
            type: 23,
            title: "Calendar",
            subtitle: "",
            description:
              "In this example, we use v-slot to assign content to the header ",
            required: false,
            property: {},
            is_create: true,
          };
          break;
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
